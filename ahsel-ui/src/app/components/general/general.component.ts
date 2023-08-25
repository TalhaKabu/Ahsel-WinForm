import { Component, OnInit } from '@angular/core';
import { GeneralService } from 'src/app/services/general/general.service';
import {
  Client,
  ClientGroupDto,
  PaymentDto,
  Project,
} from 'src/app/services/general/models';

@Component({
  selector: 'app-general',
  templateUrl: './general.component.html',
  styleUrls: ['./general.component.scss'],
})
export class GeneralComponent implements OnInit {
  //#region Fields
  projectRef: number = -1;
  projectList: Project[] = [];
  clientList: Client[] = [];
  paymentList: PaymentDto[] = [];
  groupedPaymentList: ClientGroupDto[] = [];
  //#endregion

  //#region Utils
  getProjectList = async () => {
    (await this.generalService.getProjectList()).subscribe((res) => {
      this.projectList = res;
      this.projectRef = this.projectList[0].id;
      this.getClientList();
    });
  };

  getClientList = async () => {
    (await this.generalService.getClientList(this.projectRef)).subscribe(
      (res) => {
        this.clientList = res;
        this.getGroupedPaymentList();
      }
    );
  };

  getPaymentList = async () => {
    (await this.generalService.getPaymentList(this.projectRef)).subscribe(
      (res) => {
        this.paymentList = res;
        console.log(this.paymentList);
      }
    );
  };

  getGroupedPaymentList = async () => {
    (
      await this.generalService.getGroupedPaymentList(this.projectRef)
    ).subscribe((res) => {
      this.groupedPaymentList = res;
    });
  };
  //#endregion

  //#region Ctor
  constructor(private generalService: GeneralService) {}
  //#endregion

  //#region Methods
  async ngOnInit(): Promise<void> {
    await this.getProjectList();
  }
  //#endregion
}

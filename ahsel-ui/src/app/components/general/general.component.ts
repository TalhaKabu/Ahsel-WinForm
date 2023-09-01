import { Component, OnInit } from '@angular/core';
import { DialogService, DynamicDialogRef } from 'primeng/dynamicdialog';
import { GeneralService } from 'src/app/services/general/general.service';
import {
  Client,
  ClientGroupDto,
  PaymentDto,
  Project,
} from 'src/app/services/general/models';
import { AddRecordComponent } from '../add-record/add-record.component';

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
  totalIncome: number = 0;
  totalExpense: number = 0;
  ref: DynamicDialogRef | undefined;
  //#endregion

  //#region Utils
  getProjectList = async () => {
    (await this.generalService.getProjectList()).subscribe((res) => {
      this.projectList = res;
      if (this.projectRef == -1) this.projectRef = this.projectList[0].id;
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
      this.groupedPaymentList.forEach((x) => {
        if (x.name == 'Gider') this.totalExpense += x.total;
        else this.totalIncome += x.total;
      });
    });
  };
  //#endregion

  //#region Ctor
  constructor(
    private generalService: GeneralService,
    public dialogService: DialogService
  ) {}
  //#endregion

  //#region Methods
  async ngOnInit(): Promise<void> {
    await this.getProjectList();
  }

  addOnClick() {
    console.log(this.projectList);
    this.ref = this.dialogService.open(AddRecordComponent, {
      header: 'Kayıt Ekle',
      data: {
        projectList: this.projectList,
        clientList: this.clientList,
      },
      width: '35%',
      baseZIndex: 10000,
    });
  }

  projectOnChange(): void {
    this.ngOnInit();
  }
  //#endregion
}

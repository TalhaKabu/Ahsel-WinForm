import { AfterViewInit, Component, OnInit } from '@angular/core';
import { DynamicDialogConfig, DynamicDialogRef } from 'primeng/dynamicdialog';
import { Client, Description, Project } from 'src/app/services/general/models';

@Component({
  selector: 'app-add-record',
  templateUrl: './add-record.component.html',
  styleUrls: ['./add-record.component.scss'],
})
export class AddRecordComponent implements OnInit, AfterViewInit{
  projectList: Project[] = [];
  projectRef: number = -1;
  projectName: string = '';
  date: Date = new Date();
  quantity: number = 1;
  price: number = 0;
  description: string = '';
  descriptionList: Description[] = [];
  clientList: Client[] = [];
  clientRef: number = 0;

  constructor(private config: DynamicDialogConfig, private ref: DynamicDialogRef) {
    this.projectRef = this.config.data.projectRef;
    this.projectList = this.config.data.projectList;
    this.projectName = this.projectList.find(
      (x) => x.id == this.projectRef
    )!.name;
    this.descriptionList = this.config.data.descriptionList;
    this.clientList = this.config.data.clientList;
  }
  ngAfterViewInit(): void {
  }
  ngOnInit(): void {
  }

  onSaveClick() {
    console.log(this.projectRef);
    console.log(this.date);
    console.log(this.description);
    console.log(this.clientRef);
    console.log(this.quantity);
    console.log(this.price);
  }

  onClose(){
    this.ref.close(false);
  }
}

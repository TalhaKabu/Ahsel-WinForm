import { Component } from '@angular/core';
import { DynamicDialogConfig } from 'primeng/dynamicdialog';
import { Project } from 'src/app/services/general/models';

@Component({
  selector: 'app-add-record',
  templateUrl: './add-record.component.html',
  styleUrls: ['./add-record.component.scss']
})
export class AddRecordComponent {
  projectList: Project[] = [];
  projectRef: number = -1;
  date: Date = new Date();
  quantity: number = 1;
  price: number = 0;
  description: string = '';
  descriptionRef: number = 1;

  constructor(private config: DynamicDialogConfig) {
    this.projectList = this.config.data.projectList;
  }
}

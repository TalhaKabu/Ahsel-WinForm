import { Component } from '@angular/core';
import { Project } from 'src/app/services/general/models';

@Component({
  selector: 'app-add-record',
  templateUrl: './add-record.component.html',
  styleUrls: ['./add-record.component.scss']
})
export class AddRecordComponent {
  projectList: Project[] = [];
  projectRef: number = -1;

  constructor() {

  }
}

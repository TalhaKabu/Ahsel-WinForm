import { Component, OnInit } from '@angular/core';
import { GeneralService } from 'src/app/services/general/general.service';

@Component({
  selector: 'app-general',
  templateUrl: './general.component.html',
  styleUrls: ['./general.component.scss'],
})
export class GeneralComponent implements OnInit {
  
  constructor(private generalService: GeneralService) {}

  ngOnInit(): void {
    this.generalService.getProjectList().subscribe((res) => console.log(res));
  }
}

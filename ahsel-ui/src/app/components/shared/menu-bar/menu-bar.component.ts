import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { MenuItem } from 'primeng/api';

@Component({
  selector: 'app-menu-bar',
  templateUrl: './menu-bar.component.html',
  styleUrls: ['./menu-bar.component.scss'],
})
export class MenuBarComponent {
  //#region fields
  items: MenuItem[] = [];
  //#endregion
  //#region utils

  //#endregion
  //#region ctor
  constructor(private router: Router) {}
  //#endregion

  //#region methods

  ngOnInit() {
    this.items = [
      {
        label: 'Muhasebe',
        icon: 'fa fa-boxes-stacked',
        command: (click) => {
          this.router.navigate(['/general']);
        },
      },
    ];
  }
  
  //#endregion
}

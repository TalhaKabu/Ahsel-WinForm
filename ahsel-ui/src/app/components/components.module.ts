import { NgModule } from '@angular/core';
import { ComponentRoutingModule } from './components-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { ButtonModule } from 'primeng/button';
import { TableModule } from 'primeng/table';

import { GeneralComponent } from './general/general.component';

@NgModule({
  declarations: [GeneralComponent],
  imports: [
    ComponentRoutingModule,
    HttpClientModule,
    TableModule,
    ButtonModule,
  ],
  exports: [],
  providers: [],
})
export class ComponentModule {}

import { NgModule } from '@angular/core';
import { ComponentRoutingModule } from './components-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { ButtonModule } from 'primeng/button';

import { GeneralComponent } from './general/general.component';

@NgModule({
  declarations: [GeneralComponent],
  imports: [ComponentRoutingModule, HttpClientModule, ButtonModule],
  exports: [],
  providers: [],
})
export class ComponentModule {}

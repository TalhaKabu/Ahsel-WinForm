import { NgModule } from '@angular/core';
import { ButtonModule } from 'primeng/button';

import { GeneralComponent } from './general/general.component';

@NgModule({
  declarations: [GeneralComponent],
  imports: [ButtonModule],
  exports: [],
  providers: [],
})
export class ComponentModule {}

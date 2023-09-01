import { NgModule } from '@angular/core';
import { ComponentRoutingModule } from './components-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { ButtonModule } from 'primeng/button';
import { TableModule } from 'primeng/table';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { DialogService, DynamicDialogModule } from 'primeng/dynamicdialog';
import { DropdownModule } from 'primeng/dropdown';
import { CalendarModule } from 'primeng/calendar';
import { InputNumberModule } from 'primeng/inputnumber';
import { InputTextModule } from 'primeng/inputtext';

import { GeneralComponent } from './general/general.component';
import { AddRecordComponent } from './add-record/add-record.component';

@NgModule({
  declarations: [GeneralComponent, AddRecordComponent],
  imports: [
    ComponentRoutingModule,
    HttpClientModule,
    CommonModule,
    TableModule,
    FormsModule,
    DropdownModule,
    DynamicDialogModule,
    ButtonModule,
    CalendarModule,
    InputNumberModule,
    InputTextModule,
  ],
  exports: [],
  providers: [DialogService],
})
export class ComponentModule {}

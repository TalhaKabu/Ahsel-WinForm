import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ProgressSpinnerModule } from 'primeng/progressspinner';
import { AppRoutingModule } from './app-routing.module';
import { ComponentModule } from './components/components.module';
import { MenubarModule } from 'primeng/menubar';

import { AppComponent } from './app.component';
import { Router } from '@angular/router';
import { MenuBarComponent } from './components/shared/menu-bar/menu-bar.component';

@NgModule({
  declarations: [AppComponent, MenuBarComponent],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    ProgressSpinnerModule,
    ComponentModule,
    MenubarModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {
  constructor(router: Router) {}
}

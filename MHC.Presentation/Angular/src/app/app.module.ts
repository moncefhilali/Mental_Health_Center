import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { NavbarComponent } from './components/navbar/navbar.component';
import { IntroductionComponent } from './components/introduction/introduction.component';
import { TreatmentComponent } from './components/treatment/treatment.component';

@NgModule({
  declarations: [AppComponent, HeaderComponent, NavbarComponent, IntroductionComponent, TreatmentComponent],
  imports: [BrowserModule, AppRoutingModule],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}

import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SplashComponent } from './intro/splash/splash.component';
import { DespreComponent } from './intro/despre/despre.component';

@NgModule({
  declarations: [
    AppComponent,
    SplashComponent,
    DespreComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

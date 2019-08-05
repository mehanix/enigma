import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SplashComponent } from './intro/splash/splash.component';


const routes: Routes = [
 { path: 'splash', component: SplashComponent },
 { path: 'despre', component: SplashComponent },
 { path: '', redirectTo: '/splash', pathMatch: 'full'
  },


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

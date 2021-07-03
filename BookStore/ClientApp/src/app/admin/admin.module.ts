import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ControlPanelSidebarComponent } from './components/control-panel-sidebar/control-panel-sidebar.component';
import { ControlPanelHomeComponent } from './components/control-panel-home/control-panel-home.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { ProfileComponent } from './components/profile/profile.component';
import { RouterModule, Routes, ɵangular_packages_router_router_o } from '@angular/router';
import { AuthGuard } from '@auth0/auth0-angular';

const routes: Routes = [
  {
    path: '',
    component: ControlPanelHomeComponent,
    canActivate: [AuthGuard],
    children: [
      { path: 'profile', component: ProfileComponent, canActivate: [AuthGuard], },
    ]
  },

]

@NgModule({
  declarations: [
    ControlPanelHomeComponent,
    ControlPanelSidebarComponent,
    ProfileComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  exports: [RouterModule]
})
export class AdminModule { }

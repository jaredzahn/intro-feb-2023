import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './Components/about/about.component';
import { DashboardComponent } from './Components/dashboard/dashboard.component';
import { NavigationComponent } from './Components/navigation/navigation.component';
import { ShoppingListComponent } from './Components/shopping-list/shopping-list/shopping-list.component';

const routes: Routes = [
  {
    path: 'dashboard',
    component: DashboardComponent,
  },
  {
    path: 'shopping-list',
    component: ShoppingListComponent
  },
  {
    path: 'about',
    component: AboutComponent
  },
  {
    path: 'navigation',
    component: NavigationComponent
  },
  {
    path: '**',
    component: DashboardComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

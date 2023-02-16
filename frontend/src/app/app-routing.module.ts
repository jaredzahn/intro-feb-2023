import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './Components/about/about.component';
import { CounterComponent } from './Components/counter/counter.component';
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
    path: 'counter',
    component: CounterComponent
  },
  {
    path: 'learning',
    loadChildren: () => import('./learning-resources/learning-resources.module').then(m => m.LearningResourcesModule)
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

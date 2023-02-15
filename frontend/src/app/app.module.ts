import { Injectable, NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ShoppingListComponent } from './Components/shopping-list/shopping-list/shopping-list.component';
import { DashboardComponent } from './Components/dashboard/dashboard.component';
import { AboutComponent } from './Components/about/about.component';
import { NavigationComponent } from './Components/navigation/navigation.component';
import { HttpClientModule } from '@angular/common/http';
import { StatusDataService } from './services/status-data.service';
import { CounterComponent } from './Components/counter/counter.component';
import { StoreModule } from '@ngrx/store';
import { reducers } from './state';

@NgModule({
  declarations: [
    AppComponent,
    ShoppingListComponent,
    DashboardComponent,
    AboutComponent,
    NavigationComponent,
    CounterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    StoreModule.forRoot(reducers)
  ],
  providers: [StatusDataService],
  bootstrap: [AppComponent]
})
export class AppModule { }

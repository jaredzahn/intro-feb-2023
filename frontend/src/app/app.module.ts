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
import { StoreDevtoolsModule } from '@ngrx/store-devtools';
import { CounterPrefsComponent } from './Components/counter-prefs/counter-prefs.component';
import { EffectsModule } from '@ngrx/effects';
import { CounterEffects } from './state/effects/counter.effects';
import { ApplicationEffects } from './state/effects/app.effects';

@NgModule({
  declarations: [
    AppComponent,
    ShoppingListComponent,
    DashboardComponent,
    AboutComponent,
    NavigationComponent,
    CounterComponent,
    CounterPrefsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    StoreModule.forRoot(reducers),
    StoreDevtoolsModule.instrument(),
    EffectsModule.forRoot([CounterEffects, ApplicationEffects])
  ],
  providers: [StatusDataService],
  bootstrap: [AppComponent]
})
export class AppModule { }

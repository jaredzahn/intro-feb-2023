import { ActionReducerMap, createFeatureSelector, createSelector } from "@ngrx/store";
import * as fromCounter from './reducers/counter.reducer'

//The "Application State"

export interface AppState {
    counter: fromCounter.CounterState
};

export const reducers:ActionReducerMap<AppState> = {
    counter: fromCounter.reducer
};

//1. create a "feature selector"
const selectcounterFeature = createFeatureSelector<fromCounter.CounterState>('counter');

//2. create a selector per branch of the state


//3. Any helpers (optional)


//4. What does the component need?


//5. We need a selector that returns the current of the counter.
export const selectCounterCurrent = createSelector(
    selectcounterFeature,
    (f => f.current)
)
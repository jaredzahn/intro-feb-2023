import { createActionGroup, props } from "@ngrx/store";
import { ItemEntity } from "../reducers/item.reducer";

export const itemsEvents = createActionGroup({
    source: 'Items Evens',
    events: {}
})


export const itemsDocuments = createActionGroup({
    source: 'Items Documents',
    events: {
        items: props<{ payload: ItemEntity[]}>()
    }
})
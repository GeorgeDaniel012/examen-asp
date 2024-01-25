import { Routes } from '@angular/router';
import { ViewAutoriComponent } from './view-autori/view-autori.component';
import { ViewCartiComponent } from './view-carti/view-carti.component';
import { ViewEdituriComponent } from './view-edituri/view-edituri.component';

export const routes: Routes = [
    {
        path: "",
        component: ViewAutoriComponent
    },
    {
        path: "edituri",
        component: ViewEdituriComponent
    },
    {
        path: "carti",
        component: ViewCartiComponent
    }
];

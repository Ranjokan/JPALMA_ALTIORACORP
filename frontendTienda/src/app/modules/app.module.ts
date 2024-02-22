// app.module.ts
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from '../app-routing.module';
import { AppComponent } from '../app.component';
import { RouterModule } from '@angular/router';
import { IngresoClienteComponent } from '../manejo-clientes/ingreso-cliente/ingreso-cliente.component';


@NgModule({
    declarations: [
        AppComponent,
    ],
    imports: [
        BrowserModule,
        AppRoutingModule,
        FormsModule,
        RouterModule,
        IngresoClienteComponent
    ],
    providers: [],
    bootstrap: [AppComponent]

})
export class AppModule { }

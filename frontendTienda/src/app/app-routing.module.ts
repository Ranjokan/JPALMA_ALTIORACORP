// app-routing.module.ts
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ManejoClientesComponent } from './manejo-clientes/manejo-clientes.component';
import { ManejoArticulosComponent } from './manejo-articulos/manejo-articulos.component';
import { ManejoOrdenesCompraComponent } from './manejo-ordenes-compra/manejo-ordenes-compra.component';
import { IngresoClienteComponent } from './manejo-clientes/ingreso-cliente/ingreso-cliente.component';

export const routes: Routes = [
    { path: 'manejo-clientes', component: ManejoClientesComponent, children: [
        { path: 'nuevo', component: IngresoClienteComponent },
        //{ path: 'visualizar', component: VisualizacionClientesComponent },
        //{ path: 'eliminar', component: EliminacionClientesComponent }
      ]},
  { path: 'manejo-articulos', component: ManejoArticulosComponent },
  { path: 'manejo-ordenes-compra', component: ManejoOrdenesCompraComponent },
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}

// app-routing.module.ts
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ManejoClientesComponent } from './manejo-clientes/manejo-clientes.component';
import { ManejoArticulosComponent } from './manejo-articulos/manejo-articulos.component';
import { ManejoOrdenesCompraComponent } from './manejo-ordenes-compra/manejo-ordenes-compra.component';

const routes: Routes = [
  { path: 'manejo-clientes', component: ManejoClientesComponent },
  { path: 'manejo-articulos', component: ManejoArticulosComponent },
  { path: 'manejo-ordenes-compra', component: ManejoOrdenesCompraComponent },
  { path: '', redirectTo: '/manejo-clientes', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}

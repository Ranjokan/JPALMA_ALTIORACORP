import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ClienteService {
  clientes: any[] = [];

  guardarCliente(cliente: any) {
    // Simular almacenamiento en la base de datos
    this.clientes.push(cliente);
    console.log('Cliente almacenado:', cliente);
  }
}
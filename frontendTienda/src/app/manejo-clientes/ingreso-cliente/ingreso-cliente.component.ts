// ingresar-cliente.component.ts
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ClienteService } from '../../services/ClienteService';

@Component({
  selector: 'app-ingresar-cliente',
  templateUrl: './ingreso-cliente.component.html',
  styleUrls: ['./ingreso-cliente.component.css']
})
export class IngresoClienteComponent {
  nombre: string = '';
  apellido: string = '';
  dni: string = '';

  constructor(private clienteService: ClienteService) {}

  validateNombre(value: string): boolean {
    // Validación para permitir solo letras y espacios
    return /^[a-zA-Z\s]+$/.test(value);
  }

  validateApellido(value: string): boolean {
    // Validación para permitir solo letras y espacios
    return /^[a-zA-Z\s]+$/.test(value);
  }

  validateDNI(value: string): boolean {
    // Validación permitiendo caracteres alfanuméricos
    return /^[a-zA-Z0-9]+$/.test(value);
  }

  onSubmit() {
    // Realizar validaciones
    if (this.validateNombre(this.nombre) && this.validateApellido(this.apellido) && this.validateDNI(this.dni)) {
      // Llamar al servicio para almacenar los datos en la base de datos
      this.clienteService.guardarCliente({
        nombre: this.nombre,
        apellido: this.apellido,
        dni: this.dni
      });

      // Limpiar campos después de enviar el formulario
      this.nombre = '';
      this.apellido = '';
      this.dni = '';
    } else {
      // Manejar errores de validación
      console.log('Error de validación. Verifica los datos ingresados.');
    }
  }
}

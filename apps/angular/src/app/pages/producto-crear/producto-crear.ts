import { Component, input, OnInit, output } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { Acompanamiento, Producto, ProductoPedido } from '../../models/interfaces';

@Component({
  selector: 'app-producto-crear',
  imports: [CommonModule, FormsModule, ReactiveFormsModule],
  templateUrl: './producto-crear.html',
  styleUrl: './producto-crear.css',
})
export class ProductoCrear implements OnInit {
  productos = input<Producto[]>();
  acompanamientos = input<Acompanamiento[]>();
  index = input<number>();
  onProductoSet = output<ProductoPedido>();
  miFormulario: FormGroup;
  mostrarCampoDependiente: boolean = false;

  constructor(private fb: FormBuilder) {
    this.miFormulario = this.fb.group({
      productoSeleccionado: [''],
      acompanamientoSeleccionado: [''],
      comentarios: ['']
    });
  }

  ngOnInit(): void {
    // Suscripción a los cambios del control principal
    this.miFormulario.get('productoSeleccionado')?.valueChanges.subscribe((valorSeleccionado: number) => {
      // const controlDep = this.miFormulario.get('acompanamientoSeleccionado');
      const productoSeleccionado = this.productos()?.[valorSeleccionado];
      this.mostrarCampoDependiente = productoSeleccionado?.acompanamiento === 1; // Cambia la condición según tu lógica
      this.enviarDatos();
    });


    this.miFormulario.get('acompanamientoSeleccionado')?.valueChanges.subscribe(() => {
      this.enviarDatos();
    });

    this.miFormulario.get('comentarios')?.valueChanges.subscribe(() => {
      this.enviarDatos();
    });
  }

  mostrarProducto() {
    let indexProducto = Number(this.miFormulario.get('productoSeleccionado')?.value) ?? 0;
    console.log('Producto seleccionadox:', this.productos()?.[indexProducto].acompanamiento);
  }

  enviarDatos() {
    let productoPedido: ProductoPedido = {
      index: this.index() ?? 0,
      idProducto: this.miFormulario.get('productoSeleccionado')?.value,
      idAcompanamiento: this.mostrarCampoDependiente ? this.miFormulario.get('acompanamientoSeleccionado')?.value : 0,
      observaciones: this.miFormulario.get('comentarios')?.value,
    };
    // console.log(productoPedido);
    this.onProductoSet.emit(productoPedido);
  }
}

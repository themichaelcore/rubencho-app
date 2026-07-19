import { Component } from '@angular/core';
import { DbOperations } from '../../services/db-operations';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { ProductoCrear } from "../producto-crear/producto-crear";
import { BasePedido, Producto } from '../../models/interfaces';

@Component({
  selector: 'app-pedido-crear',
  imports: [ReactiveFormsModule, ProductoCrear],
  templateUrl: './pedido-crear.html',
  styleUrl: './pedido-crear.css',
})

export class PedidoCrear {
  // comidas = ['Hamburguesa', 'Perro', 'Brocheta', 'Pincho', 'Empanada'];
  // bebidas = ['Gaseosa', 'Agua'];
  // acompañamientos = ['Pan', 'Arepa', 'Papa'];
  costoTotal: number = 0;
  listaComidas: Producto[] = [];
  listaBebidas: Producto[] = [];
  form = new FormGroup({
    checkDomicilio: new FormControl(false),
    mesa: new FormControl(''),
    comentarios: new FormControl(''),
  });
  productos: Producto[] = [];
  bebidas: Producto[] = [];

  constructor(private dbService: DbOperations) {
    this.getProductos();
  }

  crearPedido() {
    const basePedido: BasePedido = {
      BasePedido: {
        idEstado: 1,
        idColaborador: 1,
        observaciones: this.form.controls.comentarios.value ?? '',
        costo: this.costoTotal,
        mesa: Number(this.form.controls.mesa.value),
        esDomicilio: this.form.controls.checkDomicilio.value ?? false,
        productoPedidos: []
      }
    };

    console.log('Payload a enviar:', this.form.controls.comentarios);

    this.dbService.crearPedido(basePedido).subscribe({
      next: (respuesta) => {
        console.log('¡Registro creado con éxito!', respuesta);
      },
      error: (error) => {
        console.error('Ocurrió un error al guardar:', error);
      },
      complete: () => {
        console.log('Petición finalizada.');
      }
    });
  }

  getProductos(){
    this.dbService.getProductos().subscribe({
      next: (respuesta) => {
        console.log('¡Productos obtenidos!', respuesta);
        this.productos = respuesta.filter((producto: Producto) => producto.idCategoriaProducto == 1);
        this.bebidas = respuesta.filter((producto: Producto) => producto.idCategoriaProducto == 2);
      },
      error: (error) => {
        console.error('Ocurrió un error al guardar:', error);
      },
      complete: () => {
        console.log('Petición finalizada.');
      }
    });
  }

  agregarComida() {
    this.listaComidas.push({ idProducto: 0, nombre: '', precio: 0, idCategoriaProducto: 1, acompanamiento: 0 });
  }

  agregarBebida() {
    this.listaBebidas.push({ idProducto: 0, nombre: '', precio: 0, idCategoriaProducto: 2, acompanamiento: 0 });
  }

  borrarComida(comida: Producto) {
    const index = this.listaComidas.indexOf(comida);
    if (index > -1) {
      this.listaComidas.splice(index, 1);
    }
  }

  borrarBebida(bebida: Producto) {
    const index = this.listaBebidas.indexOf(bebida);
    if (index > -1) {
      this.listaBebidas.splice(index, 1);
    }
  }
}

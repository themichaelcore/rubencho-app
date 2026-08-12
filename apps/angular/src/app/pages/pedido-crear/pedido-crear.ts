import { Component } from '@angular/core';
import { DbOperations } from '../../services/db-operations';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { ProductoCrear } from "../producto-crear/producto-crear";
import { Acompanamiento, BasePedido, Producto, ProductoPedido } from '../../models/interfaces';

@Component({
  selector: 'app-pedido-crear',
  imports: [ReactiveFormsModule, ProductoCrear],
  templateUrl: './pedido-crear.html',
  styleUrl: './pedido-crear.css',
})

export class PedidoCrear {
  productos: Producto[] = [];
  bebidas: Producto[] = [];
  acompanamientos: Acompanamiento[] = [];

  costoTotal: number = 0;
  listaComidas: ProductoPedido[] = [];
  listaBebidas: ProductoPedido[] = [];
  form = new FormGroup({
    checkDomicilio: new FormControl(false),
    mesa: new FormControl(''),
    comentarios: new FormControl(''),
  });

  constructor(private dbService: DbOperations) {
    this.getProductos();
    this.getAcompanamientos();
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
        productoPedidos: this.listaComidas.concat(this.listaBebidas)
        // productoPedidos: this.listaComidas.map((x: Producto) => ({ idProducto: x.idProducto, idAcompanamiento: x.acompanamiento, observaciones: x.observaciones ?? '' }))
        //   .concat(this.listaBebidas.map((x: Producto) => ({ idProducto: x.idProducto, idAcompanamiento: x.acompanamiento, observaciones: x.observaciones ?? '' })))
      }
    };

    console.log('Payload a enviar:', basePedido);

    this.dbService.crearPedido(basePedido).subscribe({
      next: (respuesta) => {
        // console.log('¡Registro creado con éxito!', respuesta);
      },
      error: (error) => {
        // console.error('Ocurrió un error al guardar:', error);
      },
      complete: () => {
        // console.log('Petición finalizada.');
      }
    });
  }

  getProductos() {
    this.dbService.getProductos().subscribe({
      next: (respuesta) => {
        // console.log('¡Productos obtenidos!', respuesta);
        this.productos = respuesta.filter((producto: Producto) => producto.idCategoriaProducto == 1);
        this.bebidas = respuesta.filter((producto: Producto) => producto.idCategoriaProducto == 2);
      },
      error: (error) => {
        // console.error('Ocurrió un error al guardar:', error);
      },
      complete: () => {
        // console.log('Petición finalizada.');
      }
    });
  }

  getAcompanamientos() {
    this.dbService.getAcompanamientos().subscribe({
      next: (respuesta) => {
        // console.log('¡Acompanamientos obtenidos!', respuesta);
        this.acompanamientos = respuesta;
      },
      error: (error) => {
        // console.error('Ocurrió un error al guardar:', error);
      },
      complete: () => {
        // console.log('Petición finalizada.');
      }
    });
  }

  agregarComida() {
    this.listaComidas.push({ index: this.listaComidas.length + 1, idProducto: 0, idAcompanamiento: 0, observaciones: '' });
  }

  agregarBebida() {
    this.listaBebidas.push({ index: this.listaBebidas.length + 1, idProducto: 0, idAcompanamiento: 0, observaciones: '' });
  }

  borrarComida(comida: ProductoPedido) {
    const index = this.listaComidas.indexOf(comida);
    if (index > -1) {
      this.listaComidas.splice(index, 1);
    }
  }

  borrarBebida(bebida: ProductoPedido) {
    const index = this.listaBebidas.indexOf(bebida);
    if (index > -1) {
      this.listaBebidas.splice(index, 1);
    }
  }

  onComidaSet(producto: ProductoPedido) {
    console.log('Comida seleccionada:', producto);
    const index = this.listaComidas.findIndex(p => p.index === producto.index);
    if (index !== -1) {
      this.listaComidas[index] = producto;
    }
  }

  onBebidaSet(producto: ProductoPedido) {
    console.log('Bebida seleccionada:', producto);
    const index = this.listaBebidas.findIndex(p => p.index === producto.index);
    if (index !== -1) {
      this.listaBebidas[index] = producto;
    }
  }
}

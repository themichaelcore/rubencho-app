export interface BasePedido {
  BasePedido: Pedido;
}

export interface Pedido {
  idEstado: number;
  idColaborador: number;
  observaciones: string;
  costo: number;
  mesa: number | undefined;
  esDomicilio: boolean;
  productoPedidos: ProductoPedido[];
}

export interface GetPedido {
  idPedido: number;
  fecha: Date;
  idEstado: number;
  idColaborador: number;
  observaciones: string;
  costo: number;
  mesa: number | undefined;
  esDomicilio: boolean;
  productoPedidos: GetProductoPedido[];
}

export interface ProductoPedido {
  index: number;
  idProducto: number;
  idAcompanamiento: number;
  observaciones: string;
}

export interface GetProductoPedido {
  index: number;
  nombreProducto: string;
  acompanamiento: string;
  observaciones: string;
}

export interface Producto {
  idProducto: number;
  nombre: string;
  precio: number;
  idCategoriaProducto: number;
  acompanamiento: number;
  observaciones: string;
}

export interface Acompanamiento {
  idAcompanamiento: number;
  nombre: string;
}
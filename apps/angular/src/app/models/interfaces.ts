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
  productoPedidos: string[];
}

export interface Producto {
  idProducto: number;
  nombre: string;
  precio: number;
  idCategoriaProducto: number;
  acompanamiento: number;
}

export interface Acompanamiento {
  idAcompanamiento: number;
  nombre: string;
}
import { Routes } from '@angular/router';
import { Inicio } from './pages/inicio/inicio';
import { PedidoCrear } from './pages/pedido-crear/pedido-crear';
import { PedidoConsultar } from './pages/pedido-consultar/pedido-consultar';

export const routes : Routes = [
    {
        path: '',
        component: Inicio,
    },
    {
        path: 'pedidos/crear',
        component: PedidoCrear,
    },
    {
        path: 'pedidos/consultar',
        component: PedidoConsultar,
    },
    {
        path: '**',
        redirectTo: ''
    }
];
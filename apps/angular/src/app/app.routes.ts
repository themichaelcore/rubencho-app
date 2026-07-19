import { Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { Pedidos } from './pages/pedidos/pedidos';
import { Inicio } from './pages/inicio/inicio';
import { PedidoCrear } from './pages/pedido-crear/pedido-crear';
import { PedidoConsultar } from './pages/pedido-consultar/pedido-consultar';

export const routes : Routes = [
    {
        path: '',
        component: Inicio,
    },
    {
        path: 'pedidos',
        component: Pedidos,
        children: [
            { path: 'crear', component: PedidoCrear },
            { path: 'consultar', component: PedidoConsultar },
        ]
    },
    {
        path: 'pedidoscrear',
        component: PedidoCrear,
    },
    {
        path: '**',
        redirectTo: ''
    }
];
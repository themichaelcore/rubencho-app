import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PedidoCrear } from './pedido-crear';

describe('PedidoCrear', () => {
  let component: PedidoCrear;
  let fixture: ComponentFixture<PedidoCrear>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PedidoCrear],
    }).compileComponents();

    fixture = TestBed.createComponent(PedidoCrear);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

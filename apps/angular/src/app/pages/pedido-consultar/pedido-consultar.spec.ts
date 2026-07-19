import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PedidoConsultar } from './pedido-consultar';

describe('PedidoConsultar', () => {
  let component: PedidoConsultar;
  let fixture: ComponentFixture<PedidoConsultar>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PedidoConsultar],
    }).compileComponents();

    fixture = TestBed.createComponent(PedidoConsultar);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

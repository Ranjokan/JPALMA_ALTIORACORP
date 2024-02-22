import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManejoOrdenesCompraComponent } from './manejo-ordenes-compra.component';

describe('ManejoOrdenesCompraComponent', () => {
  let component: ManejoOrdenesCompraComponent;
  let fixture: ComponentFixture<ManejoOrdenesCompraComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ManejoOrdenesCompraComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ManejoOrdenesCompraComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManejoClientesComponent } from './manejo-clientes.component';

describe('ManejoClientesComponent', () => {
  let component: ManejoClientesComponent;
  let fixture: ComponentFixture<ManejoClientesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ManejoClientesComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ManejoClientesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

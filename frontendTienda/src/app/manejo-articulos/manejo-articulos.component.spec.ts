import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManejoArticulosComponent } from './manejo-articulos.component';

describe('ManejoArticulosComponent', () => {
  let component: ManejoArticulosComponent;
  let fixture: ComponentFixture<ManejoArticulosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ManejoArticulosComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ManejoArticulosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

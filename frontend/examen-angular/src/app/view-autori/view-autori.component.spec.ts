import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewAutoriComponent } from './view-autori.component';

describe('ViewAutoriComponent', () => {
  let component: ViewAutoriComponent;
  let fixture: ComponentFixture<ViewAutoriComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ViewAutoriComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ViewAutoriComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

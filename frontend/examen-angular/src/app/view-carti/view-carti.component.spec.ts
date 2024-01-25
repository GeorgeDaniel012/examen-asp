import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewCartiComponent } from './view-carti.component';

describe('ViewCartiComponent', () => {
  let component: ViewCartiComponent;
  let fixture: ComponentFixture<ViewCartiComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ViewCartiComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ViewCartiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

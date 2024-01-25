import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewEdituriComponent } from './view-edituri.component';

describe('ViewEdituriComponent', () => {
  let component: ViewEdituriComponent;
  let fixture: ComponentFixture<ViewEdituriComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ViewEdituriComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ViewEdituriComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

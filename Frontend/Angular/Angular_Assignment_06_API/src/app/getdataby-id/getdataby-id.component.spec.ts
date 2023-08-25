import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GetdatabyIDComponent } from './getdataby-id.component';

describe('GetdatabyIDComponent', () => {
  let component: GetdatabyIDComponent;
  let fixture: ComponentFixture<GetdatabyIDComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [GetdatabyIDComponent]
    });
    fixture = TestBed.createComponent(GetdatabyIDComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

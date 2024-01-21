import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OurServicesPageComponent } from './our-services-page.component';

describe('OurServicesPageComponent', () => {
  let component: OurServicesPageComponent;
  let fixture: ComponentFixture<OurServicesPageComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [OurServicesPageComponent]
    });
    fixture = TestBed.createComponent(OurServicesPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

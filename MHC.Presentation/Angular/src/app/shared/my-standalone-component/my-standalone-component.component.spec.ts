import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MyStandaloneComponentComponent } from './my-standalone-component.component';

describe('MyStandaloneComponentComponent', () => {
  let component: MyStandaloneComponentComponent;
  let fixture: ComponentFixture<MyStandaloneComponentComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [MyStandaloneComponentComponent]
    });
    fixture = TestBed.createComponent(MyStandaloneComponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

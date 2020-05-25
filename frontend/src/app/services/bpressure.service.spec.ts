import { TestBed } from '@angular/core/testing';

import { BpressureService } from './bpressure.service';

describe('BpressureService', () => {
  let service: BpressureService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(BpressureService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

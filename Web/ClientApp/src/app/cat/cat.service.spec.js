"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var cat_service_1 = require("./cat.service");
describe('CatService', function () {
    beforeEach(function () { return testing_1.TestBed.configureTestingModule({}); });
    it('should be created', function () {
        var service = testing_1.TestBed.get(cat_service_1.CatService);
        expect(service).toBeTruthy();
    });
});
//# sourceMappingURL=cat.service.spec.js.map
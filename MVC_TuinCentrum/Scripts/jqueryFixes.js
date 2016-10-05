$.validator.methods.range = function (value, element, parem) {
    var globalizedValue = value.replace(",", ".");
    return this.optional(element) || (globalizedValue >= parem[0] && globalizedValue <= parem[1]);
}
$.validator.methods.number = function (value, element) {
    return this.optional(element) || /^-?(?:\d{1,3}(?:[\s\.,]\d{3})+)(?:[\.,]\d+)?$/.test(value);
}
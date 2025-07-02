export default class JobAndService {
    _faIcon : string
    _value : string

    /** @constructs */
    constructor(jsonData) {
        this._value = jsonData["value"]
        this._faIcon = jsonData["faIcon"]
    }

    /** @return {String} */
    get faIcon() {
        return this._faIcon
    }

    /** @return {Section[]} */
    get value() {
        return this._value
    }
}
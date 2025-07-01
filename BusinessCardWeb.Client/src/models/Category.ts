import Locales from "./Locales.js"
import Section from './Section.js';

export default class Category {
    _id : string;
    _faIcon : string;
    _locales : Locales;
    _sections : Section[];
    _lastVisitedSection : Section | null;
    
    /** @constructs */
    constructor(id, faIcon, locales) {
        this._id = id
        this._faIcon = faIcon
        this._locales = new Locales(locales)
        this._sections = []
    }

    /** @return {String} */
    get id() {
        return this._id
    }

    /** @return {String} */
    get faIcon() {
        return this._faIcon
    }

    /** @return {Section[]} */
    get sections() {
        return this._sections
    }

    /** @return {Locales} */
    get locales() {
        return this._locales
    }

    /** @return {Section} */
    get lastVisitedSection() {
        return this._lastVisitedSection
    }

    /**
     * @param {Section} section
     */
    set lastVisitedSection(section) {
        this._lastVisitedSection = section
    }

    /**
     * @param {Section} section
     */
    addSection(section) {
        if(this._sections.indexOf(section) === -1) {
            this._sections.push(section)
        }
    }

    /**
     * @param {Section} section
     */
    removeSection(section) {
        const index = this._sections.indexOf(section)
        if(index !== -1) {
            this._sections.splice(index, 1)
        }
    }
}
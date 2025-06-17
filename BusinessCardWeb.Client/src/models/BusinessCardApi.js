import axios from 'axios';

export default class Article {
    constructor(baseUrl){
        this.instance = axios.create({
            baseURL: baseUrl,
            headers: {
                'Content-Type': 'application/json',
                'Accept': 'application/json'
            }
        });
    }

    async getPortfile(){
        return await this._get("BusinessCard")
    }

    async _get(url){
        try {
            const response = await this.instance.get(url);
            return response.data;
        } catch (error) {
            console.error('Error fetching data:', error);
            throw error;
        }
    }
}
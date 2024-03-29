﻿using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace HwMiles
{
    public class LocalStorageService
    {
        private readonly IJSRuntime _js;

        public LocalStorageService(IJSRuntime js)
        {
            _js = js;
        }

        public async Task<string> GetFromLocalStorage(string key)
        {
            return await _js.InvokeAsync<string>("localStorage.getItem", key);
        }

        public async Task SetLocalStorage(string key, string value)
        {
            await _js.InvokeVoidAsync("localStorage.setItem", key, value);
        }
    }
}
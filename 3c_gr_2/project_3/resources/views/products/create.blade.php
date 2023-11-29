<h3>Dodawanie produktu</h3>
<div>
    <form action="{{route('product.store')}}" method="post">
        @csrf
        <div>
            <label for="name">Nazwa produktu</label>
            <input type="text" name="name" id="name" value="{{ old('name') }}">
            @error('name')
            <div>{{ $message }}</div>
            @enderror
        </div>
        <div>
            <label for="price">Cena produktu</label>
            <input type="number" name="price" id="price" value="{{ old('price') }}">
            @error('price')
            <div>{{ $message }}</div>
            @enderror
        </div>
        <div>
            <label for="description">Opis produktu</label>
            <textarea name="description" id="description" value="{{ old('description') }}"></textarea>
            @error('description')
            <div>{{ $message }}</div>
            @enderror
        </div>
        <div>
            <button type="submit">Dodaj produkt</button>
        </div>
    </form>
</div>

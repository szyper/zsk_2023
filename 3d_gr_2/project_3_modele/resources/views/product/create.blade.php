<h3>Dodawanie produktu</h3>
<div>
    <form action="{{ route('product.store') }}" method="post">
        @csrf
        <div>
            <label for="name">Nazwa produktu</label>
            <input type="text" name="name" id="name" value="{{ old('name') }}" placeholder="Nazwa produktu">
            @error('name')
            {{ $message }}
            @enderror<br><br>
        </div>
        <div>
            <label for="price">Cena produktu</label>
            <input type="text" name="price" id="name" value="{{ old('price') }}" placeholder="Cena produktu">
            @error('price')
            {{ $message }}
            @enderror<br><br>
        </div>
        <div>
            <label for="description">Opis produktu</label>
            <textarea name="description" id="description" cols="30" rows="10">{{ old('description') }}</textarea>
            @error('description')
            {{ $message }}
            @enderror<br><br>
        </div>
        <div>
            <button type="submit">Dodaj produkt</button>
        </div>
    </form>
</div>

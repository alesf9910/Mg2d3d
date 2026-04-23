# Mg2d3d

Librería gráfica nativa en C# (C# 14 / .NET 10) con enfoque de bajo nivel:

- Backend principal Vulkan vía `LibraryImport`.
- Subsistema de texto con DirectWrite vía `LibraryImport`.
- Módulos dedicados para render 2D y 3D.
- Diseño data-oriented: `struct`, `enum`, punteros `unsafe` y control manual de memoria.
- Sin dependencias NuGet de terceros.

## Arquitectura

- `Core`: configuración y ciclo de vida del engine.
- `Memory`: allocator lineal alineado para frame arena.
- `Interop/Vulkan`: enlaces P/Invoke para Vulkan.
- `Interop/DirectWrite`: enlaces P/Invoke para DirectWrite.
- `Renderer`: coordinación de frame packets y frame graph.
- `Renderer2D`: datos y comandos para sprites/quads.
- `Renderer3D`: datos y comandos para mallas/cámara.
- `Resources`: buffers/texturas y formatos GPU.
- `Pipeline`: estados de pipeline gráfico.
- `Scene`: componentes de escena.
- `Text`: sistema tipográfico y glyph runs.

## Estado

Esta base implementa una arquitectura sólida y extensible, lista para completar la inicialización detallada de Vulkan (device/swapchain/pipelines) y el pipeline completo de texto con atlas de glifos.

# Mg2d3d

Biblioteca gráfica de bajo nivel en C# (preview C# 14 / .NET 10) orientada a máximo control:

- Arquitectura 2D + 3D separada.
- Backend Vulkan (`vulkan-1`) para render de alto rendimiento.
- Backend software para fallback/validación.
- Interop nativo solo con `LibraryImport` (sin NuGet externos).
- Texto por DirectWrite (`dwrite`).
- Diseño `unsafe` con memoria manual (`NativeMemory`, arena lineal).
- Sin clases de dominio ni asignaciones `new` en la arquitectura principal.

## Estructura

- `Core/`: contratos, tipos base y contexto de engine.
- `Memory/`: allocator nativo y arena lineal.
- `Interop/`: P/Invoke de Vulkan y DirectWrite.
- `Backend/`: implementación Vulkan y software.
- `Renderer2D/`: pipeline de sprites y comandos 2D.
- `Renderer3D/`: pipeline de malla/comandos 3D.
- `Text/`: inicialización de DirectWrite y tipos de texto.

## Estado

Se entrega una base de arquitectura robusta y extensible lista para crecer a:

- gestión completa de swapchain,
- command buffers,
- materiales/pipelines,
- carga de recursos,
- shape/text rendering avanzado.

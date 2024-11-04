// <auto-generated>
// This code is generated by csbindgen.
// DON'T CHANGE THIS DIRECTLY.
// </auto-generated>
#pragma warning disable CS8500
#pragma warning disable CS8981
using System;
using System.Runtime.InteropServices;


namespace Verkle.Bindings
{
    internal static unsafe partial class NativeMethods
    {
        const string __DllName = "c_verkle";



        [DllImport(__DllName, EntryPoint = "context_new", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        internal static extern Context* context_new();

        [DllImport(__DllName, EntryPoint = "context_free", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        internal static extern void context_free(Context* ctx);

        [DllImport(__DllName, EntryPoint = "pedersen_hash", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        internal static extern void pedersen_hash(Context* ctx, byte* address, byte* tree_index_le, byte* @out);

        [DllImport(__DllName, EntryPoint = "multi_scalar_mul", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        internal static extern void multi_scalar_mul(Context* ctx, byte* scalars, System.UIntPtr len, byte* @out);

        [DllImport(__DllName, EntryPoint = "create_proof", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        internal static extern void create_proof(Context* ctx, byte* input, System.UIntPtr len, byte* @out);

        [DllImport(__DllName, EntryPoint = "create_proof_uncompressed", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        internal static extern void create_proof_uncompressed(Context* ctx, byte* input, System.UIntPtr len, byte* @out);

        [DllImport(__DllName, EntryPoint = "verify_proof", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        internal static extern bool verify_proof(Context* ctx, byte* input, System.UIntPtr len);

        [DllImport(__DllName, EntryPoint = "verify_proof_uncompressed", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)]
        internal static extern bool verify_proof_uncompressed(Context* ctx, byte* input, System.UIntPtr len);


    }



}
﻿#nullable enable
using System;
using LanguageExt;
using static LanguageExt.Prelude;
using LanguageExt.ClassInstances;

/// <summary>
/// Extension methods for `TryAsync`
/// </summary>
public static partial class TryAsyncExtensions
{
    /// <summary>
    /// Applicative action
    /// </summary>
    /// <remarks>
    /// Applicative action 'runs' the first item then returns the result of the second (if neither fail). 
    /// </remarks>
    /// <param name="fa">Bound first argument</param>
    /// <param name="fb">Bound second argument</param>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static TryAsync<B> Action<A, B>(this TryAsync<A> fa, TryAsync<B> fb) =>
        default(ApplTryAsync<A, B>).Action(fa, fb);
    
    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static TryAsync<B> Apply<A, B>(this TryAsync<Func<A, B>> ff, TryAsync<A> fx) =>
        default(ApplTryAsync<A, B>).Apply(ff, fx);
            
    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound arguments, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <param name="fy">Bound argument</param>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static TryAsync<C> Apply<A, B, C>(this TryAsync<Func<A, B, C>> ff, TryAsync<A> fx, TryAsync<B> fy) =>
        ff.Map(curry).Apply(fx).Apply(fy);
    
    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static TryAsync<B> Apply<A, B>(this Func<A, B> ff, TryAsync<A> fx) =>
        default(ApplTryAsync<A, B>).Apply(TryAsyncSucc(ff), fx);

    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static TryAsync<Func<B, C>> Apply<A, B, C>(this TryAsync<Func<A, B, C>> ff, TryAsync<A> fx) =>
        ff.Map(curry).Apply(fx);
    
    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static TryAsync<Func<B, C>> Apply<A, B, C>(this Func<A, B, C> ff, TryAsync<A> fx) =>
        curry(ff).Apply(fx);

    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Intermediate bound value type</typeparam>
    /// <typeparam name="D">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static TryAsync<Func<B, Func<C, D>>> Apply<A, B, C, D>(this TryAsync<Func<A, B, C, D>> ff, TryAsync<A> fx) =>
        ff.Map(curry).Apply(fx);
    
    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Intermediate bound value type</typeparam>
    /// <typeparam name="D">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static TryAsync<Func<B, Func<C, D>>> Apply<A, B, C, D>(this Func<A, B, C, D> ff, TryAsync<A> fx) =>
        curry(ff).Apply(fx);

    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Intermediate bound value type</typeparam>
    /// <typeparam name="D">Intermediate bound value type</typeparam>
    /// <typeparam name="E">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static TryAsync<Func<B, Func<C, Func<D, E>>>> Apply<A, B, C, D, E>(
        this TryAsync<Func<A, B, C, D, E>> ff, 
        TryAsync<A> fx) =>
        ff.Map(curry).Apply(fx);
    
    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Intermediate bound value type</typeparam>
    /// <typeparam name="D">Intermediate bound value type</typeparam>
    /// <typeparam name="E">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static TryAsync<Func<B, Func<C, Func<D, E>>>> Apply<A, B, C, D, E>(
        this Func<A, B, C, D, E> ff, 
        TryAsync<A> fx) =>
        curry(ff).Apply(fx);    

    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Intermediate bound value type</typeparam>
    /// <typeparam name="D">Intermediate bound value type</typeparam>
    /// <typeparam name="E">Intermediate bound value type</typeparam>
    /// <typeparam name="F">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static TryAsync<Func<B, Func<C, Func<D, Func<E, F>>>>> Apply<A, B, C, D, E, F>(
        this TryAsync<Func<A, B, C, D, E, F>> ff, 
        TryAsync<A> fx) =>
        ff.Map(curry).Apply(fx);
    
    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Intermediate bound value type</typeparam>
    /// <typeparam name="D">Intermediate bound value type</typeparam>
    /// <typeparam name="E">Intermediate bound value type</typeparam>
    /// <typeparam name="F">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static TryAsync<Func<B, Func<C, Func<D, Func<E, F>>>>> Apply<A, B, C, D, E, F>(
        this Func<A, B, C, D, E, F> ff, 
        TryAsync<A> fx) =>
        curry(ff).Apply(fx);

    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Intermediate bound value type</typeparam>
    /// <typeparam name="D">Intermediate bound value type</typeparam>
    /// <typeparam name="E">Intermediate bound value type</typeparam>
    /// <typeparam name="F">Intermediate bound value type</typeparam>
    /// <typeparam name="G">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static TryAsync<Func<B, Func<C, Func<D, Func<E, Func<F, G>>>>>> Apply<A, B, C, D, E, F, G>(
        this TryAsync<Func<A, B, C, D, E, F, G>> ff, 
        TryAsync<A> fx) =>
        ff.Map(curry).Apply(fx);
    
    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Intermediate bound value type</typeparam>
    /// <typeparam name="D">Intermediate bound value type</typeparam>
    /// <typeparam name="E">Intermediate bound value type</typeparam>
    /// <typeparam name="F">Intermediate bound value type</typeparam>
    /// <typeparam name="G">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static TryAsync<Func<B, Func<C, Func<D, Func<E, Func<F, G>>>>>> Apply<A, B, C, D, E, F, G>(
        this Func<A, B, C, D, E, F, G> ff, 
        TryAsync<A> fx) =>
        curry(ff).Apply(fx);    

    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Intermediate bound value type</typeparam>
    /// <typeparam name="D">Intermediate bound value type</typeparam>
    /// <typeparam name="E">Intermediate bound value type</typeparam>
    /// <typeparam name="F">Intermediate bound value type</typeparam>
    /// <typeparam name="G">Intermediate bound value type</typeparam>
    /// <typeparam name="H">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static TryAsync<Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, H>>>>>>> Apply<A, B, C, D, E, F, G, H>(
        this TryAsync<Func<A, B, C, D, E, F, G, H>> ff, 
        TryAsync<A> fx) =>
        ff.Map(curry).Apply(fx);
    
    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Intermediate bound value type</typeparam>
    /// <typeparam name="D">Intermediate bound value type</typeparam>
    /// <typeparam name="E">Intermediate bound value type</typeparam>
    /// <typeparam name="F">Intermediate bound value type</typeparam>
    /// <typeparam name="G">Intermediate bound value type</typeparam>
    /// <typeparam name="H">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static TryAsync<Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, H>>>>>>> Apply<A, B, C, D, E, F, G, H>(
        this Func<A, B, C, D, E, F, G, H> ff, 
        TryAsync<A> fx) =>
        curry(ff).Apply(fx);    

    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Intermediate bound value type</typeparam>
    /// <typeparam name="D">Intermediate bound value type</typeparam>
    /// <typeparam name="E">Intermediate bound value type</typeparam>
    /// <typeparam name="F">Intermediate bound value type</typeparam>
    /// <typeparam name="G">Intermediate bound value type</typeparam>
    /// <typeparam name="H">Intermediate bound value type</typeparam>
    /// <typeparam name="I">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static TryAsync<Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, Func<H, I>>>>>>>> Apply<A, B, C, D, E, F, G, H, I>(
        this TryAsync<Func<A, B, C, D, E, F, G, H, I>> ff, 
        TryAsync<A> fx) =>
        ff.Map(curry).Apply(fx);
    
    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Intermediate bound value type</typeparam>
    /// <typeparam name="D">Intermediate bound value type</typeparam>
    /// <typeparam name="E">Intermediate bound value type</typeparam>
    /// <typeparam name="F">Intermediate bound value type</typeparam>
    /// <typeparam name="G">Intermediate bound value type</typeparam>
    /// <typeparam name="H">Intermediate bound value type</typeparam>
    /// <typeparam name="I">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static TryAsync<Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, Func<H, I>>>>>>>> Apply<A, B, C, D, E, F, G, H, I>(
        this Func<A, B, C, D, E, F, G, H, I> ff, 
        TryAsync<A> fx) =>
        curry(ff).Apply(fx);    
}


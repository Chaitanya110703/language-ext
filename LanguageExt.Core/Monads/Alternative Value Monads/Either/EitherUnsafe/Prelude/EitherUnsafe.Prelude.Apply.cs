﻿using System;
using LanguageExt;
using static LanguageExt.Prelude;
using LanguageExt.ClassInstances;

namespace LanguageExt;

/// <summary>
/// Extension methods for `EitherUnsafe`
/// </summary>
public static partial class Prelude
{
    /// <summary>
    /// Applicative action
    /// </summary>
    /// <remarks>
    /// Applicative action 'runs' the first item then returns the result of the second (if nEitherUnsafe fail). 
    /// </remarks>
    /// <param name="fa">Bound first argument</param>
    /// <param name="fb">Bound second argument</param>
    /// <typeparam name="L">Alternative value</typeparam>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static EitherUnsafe<L, B> action<L, A, B>(EitherUnsafe<L, A> fa, EitherUnsafe<L, B> fb) =>
        default(ApplEitherUnsafe<L, A, B>).Action(fa, fb);
    
    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="L">Alternative value</typeparam>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static EitherUnsafe<L, B> apply<L, A, B>(EitherUnsafe<L, Func<A, B>> ff, EitherUnsafe<L, A> fx) =>
        default(ApplEitherUnsafe<L, A, B>).Apply(ff, fx);
        
    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound arguments, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <param name="fy">Bound argument</param>
    /// <typeparam name="L">Alternative value</typeparam>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static EitherUnsafe<L, C> apply<L, A, B, C>(EitherUnsafe<L, Func<A, B, C>> ff, EitherUnsafe<L, A> fx, EitherUnsafe<L, B> fy) =>
        ff.Map(curry).Apply(fx).Apply(fy);

    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="L">Alternative value</typeparam>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static EitherUnsafe<L, B> apply<L, A, B>(Func<A, B> ff, EitherUnsafe<L, A> fx) =>
        default(ApplEitherUnsafe<L, A, B>).Apply(ff, fx);

    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="L">Alternative value</typeparam>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static EitherUnsafe<L, Func<B, C>> apply<L, A, B, C>(EitherUnsafe<L, Func<A, B, C>> ff, EitherUnsafe<L, A> fx) =>
        ff.Map(curry).Apply(fx);
    
    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="L">Alternative value</typeparam>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static EitherUnsafe<L, Func<B, C>> apply<L, A, B, C>(Func<A, B, C> ff, EitherUnsafe<L, A> fx) =>
        curry(ff).Apply(fx);

    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="L">Alternative value</typeparam>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Intermediate bound value type</typeparam>
    /// <typeparam name="D">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static EitherUnsafe<L, Func<B, Func<C, D>>> apply<L, A, B, C, D>(EitherUnsafe<L, Func<A, B, C, D>> ff, EitherUnsafe<L, A> fx) =>
        ff.Map(curry).Apply(fx);
    
    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="L">Alternative value</typeparam>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Intermediate bound value type</typeparam>
    /// <typeparam name="D">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static EitherUnsafe<L, Func<B, Func<C, D>>> apply<L, A, B, C, D>(Func<A, B, C, D> ff, EitherUnsafe<L, A> fx) =>
        curry(ff).Apply(fx);

    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="L">Alternative value</typeparam>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Intermediate bound value type</typeparam>
    /// <typeparam name="D">Intermediate bound value type</typeparam>
    /// <typeparam name="E">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static EitherUnsafe<L, Func<B, Func<C, Func<D, E>>>> apply<L, A, B, C, D, E>(
        EitherUnsafe<L, Func<A, B, C, D, E>> ff, 
        EitherUnsafe<L, A> fx) =>
        ff.Map(curry).Apply(fx);
    
    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="L">Alternative value</typeparam>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Intermediate bound value type</typeparam>
    /// <typeparam name="D">Intermediate bound value type</typeparam>
    /// <typeparam name="E">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static EitherUnsafe<L, Func<B, Func<C, Func<D, E>>>> apply<L, A, B, C, D, E>(
        Func<A, B, C, D, E> ff, 
        EitherUnsafe<L, A> fx) =>
        curry(ff).Apply(fx);    

    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="L">Alternative value</typeparam>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Intermediate bound value type</typeparam>
    /// <typeparam name="D">Intermediate bound value type</typeparam>
    /// <typeparam name="E">Intermediate bound value type</typeparam>
    /// <typeparam name="F">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static EitherUnsafe<L, Func<B, Func<C, Func<D, Func<E, F>>>>> apply<L, A, B, C, D, E, F>(
        EitherUnsafe<L, Func<A, B, C, D, E, F>> ff, 
        EitherUnsafe<L, A> fx) =>
        ff.Map(curry).Apply(fx);
    
    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="L">Alternative value</typeparam>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Intermediate bound value type</typeparam>
    /// <typeparam name="D">Intermediate bound value type</typeparam>
    /// <typeparam name="E">Intermediate bound value type</typeparam>
    /// <typeparam name="F">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static EitherUnsafe<L, Func<B, Func<C, Func<D, Func<E, F>>>>> apply<L, A, B, C, D, E, F>(
        Func<A, B, C, D, E, F> ff, 
        EitherUnsafe<L, A> fx) =>
        curry(ff).Apply(fx);

    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="L">Alternative value</typeparam>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Intermediate bound value type</typeparam>
    /// <typeparam name="D">Intermediate bound value type</typeparam>
    /// <typeparam name="E">Intermediate bound value type</typeparam>
    /// <typeparam name="F">Intermediate bound value type</typeparam>
    /// <typeparam name="G">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static EitherUnsafe<L, Func<B, Func<C, Func<D, Func<E, Func<F, G>>>>>> apply<L, A, B, C, D, E, F, G>(
        EitherUnsafe<L, Func<A, B, C, D, E, F, G>> ff, 
        EitherUnsafe<L, A> fx) =>
        ff.Map(curry).Apply(fx);
    
    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="L">Alternative value</typeparam>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Intermediate bound value type</typeparam>
    /// <typeparam name="D">Intermediate bound value type</typeparam>
    /// <typeparam name="E">Intermediate bound value type</typeparam>
    /// <typeparam name="F">Intermediate bound value type</typeparam>
    /// <typeparam name="G">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static EitherUnsafe<L, Func<B, Func<C, Func<D, Func<E, Func<F, G>>>>>> apply<L, A, B, C, D, E, F, G>(
        Func<A, B, C, D, E, F, G> ff, 
        EitherUnsafe<L, A> fx) =>
        curry(ff).Apply(fx);    

    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="L">Alternative value</typeparam>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Intermediate bound value type</typeparam>
    /// <typeparam name="D">Intermediate bound value type</typeparam>
    /// <typeparam name="E">Intermediate bound value type</typeparam>
    /// <typeparam name="F">Intermediate bound value type</typeparam>
    /// <typeparam name="G">Intermediate bound value type</typeparam>
    /// <typeparam name="H">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static EitherUnsafe<L, Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, H>>>>>>> apply<L, A, B, C, D, E, F, G, H>(
        EitherUnsafe<L, Func<A, B, C, D, E, F, G, H>> ff, 
        EitherUnsafe<L, A> fx) =>
        ff.Map(curry).Apply(fx);
    
    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="L">Alternative value</typeparam>
    /// <typeparam name="A">Input bound value type</typeparam>
    /// <typeparam name="B">Intermediate bound value type</typeparam>
    /// <typeparam name="C">Intermediate bound value type</typeparam>
    /// <typeparam name="D">Intermediate bound value type</typeparam>
    /// <typeparam name="E">Intermediate bound value type</typeparam>
    /// <typeparam name="F">Intermediate bound value type</typeparam>
    /// <typeparam name="G">Intermediate bound value type</typeparam>
    /// <typeparam name="H">Output bound value type</typeparam>
    /// <returns>Bound result of the application of the function to the argument</returns>
    public static EitherUnsafe<L, Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, H>>>>>>> apply<L, A, B, C, D, E, F, G, H>(
        Func<A, B, C, D, E, F, G, H> ff, 
        EitherUnsafe<L, A> fx) =>
        curry(ff).Apply(fx);    

    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="L">Alternative value</typeparam>
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
    public static EitherUnsafe<L, Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, Func<H, I>>>>>>>> apply<L, A, B, C, D, E, F, G, H, I>(
        EitherUnsafe<L, Func<A, B, C, D, E, F, G, H, I>> ff, 
        EitherUnsafe<L, A> fx) =>
        ff.Map(curry).Apply(fx);
    
    /// <summary>
    /// Applicative apply
    /// </summary>
    /// <remarks>
    /// Applies the bound function to the bound argument, returning a bound result. 
    /// </remarks>
    /// <param name="ff">Bound function</param>
    /// <param name="fx">Bound argument</param>
    /// <typeparam name="L">Alternative value</typeparam>
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
    public static EitherUnsafe<L, Func<B, Func<C, Func<D, Func<E, Func<F, Func<G, Func<H, I>>>>>>>> apply<L, A, B, C, D, E, F, G, H, I>(
        Func<A, B, C, D, E, F, G, H, I> ff, 
        EitherUnsafe<L, A> fx) =>
        curry(ff).Apply(fx);    
}


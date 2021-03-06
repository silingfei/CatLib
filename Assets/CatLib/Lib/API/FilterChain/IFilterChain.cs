﻿/*
 * This file is part of the CatLib package.
 *
 * (c) Yu Bin <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: http://catlib.io/
 */
 
using System;

namespace CatLib.API.FilterChain
{

    /// <summary>
    /// 过滤器链
    /// </summary>
    public interface IFilterChain
    {

        IFilterChain<TIn> Create<TIn>();

        IFilterChain<TIn, TOut> Create<TIn, TOut>();
    }

    /// <summary>
    /// 过滤器链
    /// </summary>
    /// <typeparam name="TIn"></typeparam>
    /// <typeparam name="TOut"></typeparam>
    public interface IFilterChain<TIn>
    {

        IFilterChain<TIn> Add(Action<TIn, IFilterChain<TIn>> filter);

        IFilterChain<TIn> Add(IFilter<TIn> filter);

        IFilterChain<TIn> Then(Action<TIn> then);

        void Do(TIn inData);

    }

    /// <summary>
    /// 过滤器链
    /// </summary>
    /// <typeparam name="TIn"></typeparam>
    /// <typeparam name="TOut"></typeparam>
    public interface IFilterChain<TIn, TOut>
    {

        IFilterChain<TIn, TOut> Add(Action<TIn, TOut, IFilterChain<TIn, TOut>> filter);

        IFilterChain<TIn, TOut> Add(IFilter<TIn, TOut> filter);

        IFilterChain<TIn, TOut> Then(Action<TIn, TOut> then);

        void Do(TIn inData, TOut outData);

    }

}
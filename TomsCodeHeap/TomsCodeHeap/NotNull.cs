﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ch.froorider.codeheap
{
    /// <summary>  
    /// <para>  
    /// Wrapper around a reference that ensures the reference is not <c>null</c>.  
    /// Provides implicit cast operators to automatically wrap and unwrap  
    /// values.  
    /// </para>  
    /// <para>  
    /// NotNull{T} can be used as an argument to a method to ensure that  
    /// no <c>null</c> values are passed to the method in place of manually  
    /// throwing an <see cref="ArgumentNullException"/>. It has an added  
    /// benefit over that because using it as an argument type clearly  
    /// communicates to the caller the expectation of the method.  
    /// </para>  
    /// </summary>  
    /// <typeparam name="T">Type being wrapped.</typeparam>
    [Serializable]
    public class NotNull<T>
    {
        private T wrappedObject;

        /// <summary>  
        /// Creates a new wrapper around the given reference.  
        /// </summary>  
        /// <remarks>Explicitly calling the constructor is rarely needed. Usually the  
        /// implicit cast is simpler.</remarks>  
        /// <param name="objectToWrap">The reference to wrap.</param>  
        /// <exception cref="ArgumentNullException">If <c>maybeNull</c> is <c>null</c>.</exception>  
        public NotNull(T objectToWrap)
        {
            if (objectToWrap == null) throw new ArgumentNullException("maybeNull");
            this.wrappedObject = objectToWrap;
        }

        /// <summary>  
        /// Gets and sets the non-null reference being wrapped by this  
        /// NotNull{T}.  
        /// </summary>  
        /// <exception cref="ArgumentNullException">If <c>value</c> is <c>null</c>.</exception>
        public T WrappedObject
        {
            get { return this.wrappedObject; }
            set
            {
                if (value == null) throw new ArgumentNullException("value");
                this.wrappedObject = value;
            }
        }

        /// <summary>  
        /// Automatically unwraps the non-<c>null</c> object being wrapped  
        /// by this NotNull{T}.  
        /// </summary>  
        /// <param name="wrappedObject">The wrapper.</param>  
        /// <returns>The raw object being wrapped.</returns>
        public static implicit operator T(NotNull<T> wrappedObject)
        {
            return wrappedObject.WrappedObject;
        }

        /// <summary>  
        /// Automatically wraps an object in a NotNull{T}. Will throw  
        /// an <see cref="ArgumentNullException"/> if the value being  
        /// wrapped is <c>null</c>.  
        /// </summary>  
        /// <param name="objectToWrap">The raw reference to wrap.</param>  
        /// <returns>A new NotNull{T} that wraps the value, provided the  
        /// value is not <c>null</c>.</returns>  
        /// <exception cref="ArgumentNullException">If <c>maybeNull</c> is <c>null</c>.</exception>  
        public static implicit operator NotNull<T>(T objectToWrap)
        {
            return new NotNull<T>(objectToWrap);
        }

    }
}

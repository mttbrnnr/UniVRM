﻿
using System;
using System.Collections.Generic;
using UniJSON;

namespace UniGLTF {

    static public class IFormatterExtensionsGltf
    {


    /// gltf
    public static void GenSerialize(this JsonFormatter f, glTF value)
    {
        f.BeginMap(0); // dummy

        if(value.asset!=null)
        {
            f.Key("asset"); f.GenSerialize(value.asset);
        }

        if(value.buffers!=null && value.buffers.Count>0)
        {
            f.Key("buffers"); f.GenSerialize(value.buffers);
        }

        if(value.bufferViews!=null && value.bufferViews.Count>0)
        {
            f.Key("bufferViews"); f.GenSerialize(value.bufferViews);
        }

        if(value.accessors!=null && value.accessors.Count>0)
        {
            f.Key("accessors"); f.GenSerialize(value.accessors);
        }

        if(value.textures!=null && value.textures.Count>0)
        {
            f.Key("textures"); f.GenSerialize(value.textures);
        }

        if(value.samplers!=null && value.samplers.Count>0)
        {
            f.Key("samplers"); f.GenSerialize(value.samplers);
        }

        if(value.images!=null && value.images.Count>0)
        {
            f.Key("images"); f.GenSerialize(value.images);
        }

        if(value.materials!=null && value.materials.Count>0)
        {
            f.Key("materials"); f.GenSerialize(value.materials);
        }

        if(value.meshes!=null && value.meshes.Count>0)
        {
            f.Key("meshes"); f.GenSerialize(value.meshes);
        }

        if(value.nodes!=null && value.nodes.Count>0)
        {
            f.Key("nodes"); f.GenSerialize(value.nodes);
        }

        if(value.skins!=null && value.skins.Count>0)
        {
            f.Key("skins"); f.GenSerialize(value.skins);
        }

        
        {
            f.Key("scene"); f.GenSerialize(value.scene);
        }

        if(value.scenes!=null && value.scenes.Count>0)
        {
            f.Key("scenes"); f.GenSerialize(value.scenes);
        }

        if(value.animations!=null && value.animations.Count>0)
        {
            f.Key("animations"); f.GenSerialize(value.animations);
        }

        if(value.cameras!=null && value.cameras.Count>0)
        {
            f.Key("cameras"); f.GenSerialize(value.cameras);
        }

        if(value.extensionsUsed!=null && value.extensionsUsed.Count>0)
        {
            f.Key("extensionsUsed"); f.GenSerialize(value.extensionsUsed);
        }

        if(false && value.extensionsRequired!=null && value.extensionsRequired.Count>0)
        {
            f.Key("extensionsRequired"); f.GenSerialize(value.extensionsRequired);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        f.EndMap();
    }

    /// gltf/asset
    public static void GenSerialize(this JsonFormatter f, glTFAssets value)
    {
        f.BeginMap(0); // dummy

        if(!string.IsNullOrEmpty(value.generator))
        {
            f.Key("generator"); f.GenSerialize(value.generator);
        }

        if(!string.IsNullOrEmpty(value.version))
        {
            f.Key("version"); f.GenSerialize(value.version);
        }

        if(!string.IsNullOrEmpty(value.copyright))
        {
            f.Key("copyright"); f.GenSerialize(value.copyright);
        }

        if(!string.IsNullOrEmpty(value.minVersion))
        {
            f.Key("minVersion"); f.GenSerialize(value.minVersion);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        f.EndMap();
    }

    public static void GenSerialize(this JsonFormatter f, String value)
    {
        f.Value(value);
    }

    /// gltf/buffers
    public static void GenSerialize(this JsonFormatter f, List<glTFBuffer> value)
    {
        f.BeginList(value.Count);
        foreach (var x in value)
        {
            f.GenSerialize(x);
        }
        f.EndList();
    }

    /// gltf/buffers[]
    public static void GenSerialize(this JsonFormatter f, glTFBuffer value)
    {
        f.BeginMap(0); // dummy

        if(!string.IsNullOrEmpty(value.uri))
        {
            f.Key("uri"); f.GenSerialize(value.uri);
        }

        
        {
            f.Key("byteLength"); f.GenSerialize(value.byteLength);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        if(!string.IsNullOrEmpty(value.name))
        {
            f.Key("name"); f.GenSerialize(value.name);
        }

        f.EndMap();
    }

    public static void GenSerialize(this JsonFormatter f, Int32 value)
    {
        f.Value(value);
    }

    /// gltf/bufferViews
    public static void GenSerialize(this JsonFormatter f, List<glTFBufferView> value)
    {
        f.BeginList(value.Count);
        foreach (var x in value)
        {
            f.GenSerialize(x);
        }
        f.EndList();
    }

    /// gltf/bufferViews[]
    public static void GenSerialize(this JsonFormatter f, glTFBufferView value)
    {
        f.BeginMap(0); // dummy

        
        {
            f.Key("buffer"); f.GenSerialize(value.buffer);
        }

        
        {
            f.Key("byteOffset"); f.GenSerialize(value.byteOffset);
        }

        
        {
            f.Key("byteLength"); f.GenSerialize(value.byteLength);
        }

        if(value.target!=0)
        {
            f.Key("target"); f.GenSerialize(value.target);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        if(!string.IsNullOrEmpty(value.name))
        {
            f.Key("name"); f.GenSerialize(value.name);
        }

        f.EndMap();
    }

    public static void GenSerialize(this JsonFormatter f, glBufferTarget value)
    {
        f.Value((int)value);
    }

    /// gltf/accessors
    public static void GenSerialize(this JsonFormatter f, List<glTFAccessor> value)
    {
        f.BeginList(value.Count);
        foreach (var x in value)
        {
            f.GenSerialize(x);
        }
        f.EndList();
    }

    /// gltf/accessors[]
    public static void GenSerialize(this JsonFormatter f, glTFAccessor value)
    {
        f.BeginMap(0); // dummy

        if(value.bufferView>=0)
        {
            f.Key("bufferView"); f.GenSerialize(value.bufferView);
        }

        if(value.bufferView>=0)
        {
            f.Key("byteOffset"); f.GenSerialize(value.byteOffset);
        }

        if(!string.IsNullOrEmpty(value.type))
        {
            f.Key("type"); f.GenSerialize(value.type);
        }

        
        {
            f.Key("componentType"); f.GenSerialize(value.componentType);
        }

        
        {
            f.Key("count"); f.GenSerialize(value.count);
        }

        if(value.max!=null && value.max.Length>0)
        {
            f.Key("max"); f.GenSerialize(value.max);
        }

        if(value.min!=null && value.min.Length>0)
        {
            f.Key("min"); f.GenSerialize(value.min);
        }

        
        {
            f.Key("normalized"); f.GenSerialize(value.normalized);
        }

        if(value.sparse!=null && value.sparse.count>0)
        {
            f.Key("sparse"); f.GenSerialize(value.sparse);
        }

        if(!string.IsNullOrEmpty(value.name))
        {
            f.Key("name"); f.GenSerialize(value.name);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        f.EndMap();
    }

    public static void GenSerialize(this JsonFormatter f, glComponentType value)
    {
        f.Value((int)value);
    }

    /// gltf/accessors[]/max
    public static void GenSerialize(this JsonFormatter f, Single[] value)
    {
        f.BeginList(value.Length);
        foreach (var x in value)
        {
            f.GenSerialize(x);
        }
        f.EndList();
    }
                    
    public static void GenSerialize(this JsonFormatter f, Single value)
    {
        f.Value(value);
    }

    public static void GenSerialize(this JsonFormatter f, Boolean value)
    {
        f.Value(value);
    }

    /// gltf/accessors[]/sparse
    public static void GenSerialize(this JsonFormatter f, glTFSparse value)
    {
        f.BeginMap(0); // dummy

        
        {
            f.Key("count"); f.GenSerialize(value.count);
        }

        if(value.indices!=null)
        {
            f.Key("indices"); f.GenSerialize(value.indices);
        }

        if(value.values!=null)
        {
            f.Key("values"); f.GenSerialize(value.values);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        f.EndMap();
    }

    /// gltf/accessors[]/sparse/indices
    public static void GenSerialize(this JsonFormatter f, glTFSparseIndices value)
    {
        f.BeginMap(0); // dummy

        
        {
            f.Key("bufferView"); f.GenSerialize(value.bufferView);
        }

        
        {
            f.Key("byteOffset"); f.GenSerialize(value.byteOffset);
        }

        
        {
            f.Key("componentType"); f.GenSerialize(value.componentType);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        f.EndMap();
    }

    /// gltf/accessors[]/sparse/values
    public static void GenSerialize(this JsonFormatter f, glTFSparseValues value)
    {
        f.BeginMap(0); // dummy

        
        {
            f.Key("bufferView"); f.GenSerialize(value.bufferView);
        }

        
        {
            f.Key("byteOffset"); f.GenSerialize(value.byteOffset);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        f.EndMap();
    }

    /// gltf/textures
    public static void GenSerialize(this JsonFormatter f, List<glTFTexture> value)
    {
        f.BeginList(value.Count);
        foreach (var x in value)
        {
            f.GenSerialize(x);
        }
        f.EndList();
    }

    /// gltf/textures[]
    public static void GenSerialize(this JsonFormatter f, glTFTexture value)
    {
        f.BeginMap(0); // dummy

        
        {
            f.Key("sampler"); f.GenSerialize(value.sampler);
        }

        
        {
            f.Key("source"); f.GenSerialize(value.source);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        if(!string.IsNullOrEmpty(value.name))
        {
            f.Key("name"); f.GenSerialize(value.name);
        }

        f.EndMap();
    }

    /// gltf/samplers
    public static void GenSerialize(this JsonFormatter f, List<glTFTextureSampler> value)
    {
        f.BeginList(value.Count);
        foreach (var x in value)
        {
            f.GenSerialize(x);
        }
        f.EndList();
    }

    /// gltf/samplers[]
    public static void GenSerialize(this JsonFormatter f, glTFTextureSampler value)
    {
        f.BeginMap(0); // dummy

        
        {
            f.Key("magFilter"); f.GenSerialize(value.magFilter);
        }

        
        {
            f.Key("minFilter"); f.GenSerialize(value.minFilter);
        }

        
        {
            f.Key("wrapS"); f.GenSerialize(value.wrapS);
        }

        
        {
            f.Key("wrapT"); f.GenSerialize(value.wrapT);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        if(!string.IsNullOrEmpty(value.name))
        {
            f.Key("name"); f.GenSerialize(value.name);
        }

        f.EndMap();
    }

    public static void GenSerialize(this JsonFormatter f, glFilter value)
    {
        f.Value((int)value);
    }

    public static void GenSerialize(this JsonFormatter f, glWrap value)
    {
        f.Value((int)value);
    }

    /// gltf/images
    public static void GenSerialize(this JsonFormatter f, List<glTFImage> value)
    {
        f.BeginList(value.Count);
        foreach (var x in value)
        {
            f.GenSerialize(x);
        }
        f.EndList();
    }

    /// gltf/images[]
    public static void GenSerialize(this JsonFormatter f, glTFImage value)
    {
        f.BeginMap(0); // dummy

        if(!string.IsNullOrEmpty(value.name))
        {
            f.Key("name"); f.GenSerialize(value.name);
        }

        if(!string.IsNullOrEmpty(value.uri))
        {
            f.Key("uri"); f.GenSerialize(value.uri);
        }

        
        {
            f.Key("bufferView"); f.GenSerialize(value.bufferView);
        }

        if(!string.IsNullOrEmpty(value.mimeType))
        {
            f.Key("mimeType"); f.GenSerialize(value.mimeType);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        f.EndMap();
    }

    /// gltf/materials
    public static void GenSerialize(this JsonFormatter f, List<glTFMaterial> value)
    {
        f.BeginList(value.Count);
        foreach (var x in value)
        {
            f.GenSerialize(x);
        }
        f.EndList();
    }

    /// gltf/materials[]
    public static void GenSerialize(this JsonFormatter f, glTFMaterial value)
    {
        f.BeginMap(0); // dummy

        if(!string.IsNullOrEmpty(value.name))
        {
            f.Key("name"); f.GenSerialize(value.name);
        }

        if(value.pbrMetallicRoughness!=null)
        {
            f.Key("pbrMetallicRoughness"); f.GenSerialize(value.pbrMetallicRoughness);
        }

        if(value.normalTexture!=null)
        {
            f.Key("normalTexture"); f.GenSerialize(value.normalTexture);
        }

        if(value.occlusionTexture!=null)
        {
            f.Key("occlusionTexture"); f.GenSerialize(value.occlusionTexture);
        }

        if(value.emissiveTexture!=null)
        {
            f.Key("emissiveTexture"); f.GenSerialize(value.emissiveTexture);
        }

        if(value.emissiveFactor!=null)
        {
            f.Key("emissiveFactor"); f.GenSerialize(value.emissiveFactor);
        }

        if(!string.IsNullOrEmpty(value.alphaMode))
        {
            f.Key("alphaMode"); f.GenSerialize(value.alphaMode);
        }

        if(value.alphaMode == "MASK")
        {
            f.Key("alphaCutoff"); f.GenSerialize(value.alphaCutoff);
        }

        
        {
            f.Key("doubleSided"); f.GenSerialize(value.doubleSided);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        f.EndMap();
    }

    /// gltf/materials[]/pbrMetallicRoughness
    public static void GenSerialize(this JsonFormatter f, glTFPbrMetallicRoughness value)
    {
        f.BeginMap(0); // dummy

        if(value.baseColorTexture!=null)
        {
            f.Key("baseColorTexture"); f.GenSerialize(value.baseColorTexture);
        }

        if(value.baseColorFactor!=null)
        {
            f.Key("baseColorFactor"); f.GenSerialize(value.baseColorFactor);
        }

        if(value.metallicRoughnessTexture!=null)
        {
            f.Key("metallicRoughnessTexture"); f.GenSerialize(value.metallicRoughnessTexture);
        }

        
        {
            f.Key("metallicFactor"); f.GenSerialize(value.metallicFactor);
        }

        
        {
            f.Key("roughnessFactor"); f.GenSerialize(value.roughnessFactor);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        f.EndMap();
    }

    /// gltf/materials[]/pbrMetallicRoughness/baseColorTexture
    public static void GenSerialize(this JsonFormatter f, glTFMaterialBaseColorTextureInfo value)
    {
        f.BeginMap(0); // dummy

        
        {
            f.Key("index"); f.GenSerialize(value.index);
        }

        
        {
            f.Key("texCoord"); f.GenSerialize(value.texCoord);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        f.EndMap();
    }

    /// gltf/materials[]/pbrMetallicRoughness/metallicRoughnessTexture
    public static void GenSerialize(this JsonFormatter f, glTFMaterialMetallicRoughnessTextureInfo value)
    {
        f.BeginMap(0); // dummy

        
        {
            f.Key("index"); f.GenSerialize(value.index);
        }

        
        {
            f.Key("texCoord"); f.GenSerialize(value.texCoord);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        f.EndMap();
    }

    /// gltf/materials[]/normalTexture
    public static void GenSerialize(this JsonFormatter f, glTFMaterialNormalTextureInfo value)
    {
        f.BeginMap(0); // dummy

        
        {
            f.Key("scale"); f.GenSerialize(value.scale);
        }

        
        {
            f.Key("index"); f.GenSerialize(value.index);
        }

        
        {
            f.Key("texCoord"); f.GenSerialize(value.texCoord);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        f.EndMap();
    }

    /// gltf/materials[]/occlusionTexture
    public static void GenSerialize(this JsonFormatter f, glTFMaterialOcclusionTextureInfo value)
    {
        f.BeginMap(0); // dummy

        
        {
            f.Key("strength"); f.GenSerialize(value.strength);
        }

        
        {
            f.Key("index"); f.GenSerialize(value.index);
        }

        
        {
            f.Key("texCoord"); f.GenSerialize(value.texCoord);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        f.EndMap();
    }

    /// gltf/materials[]/emissiveTexture
    public static void GenSerialize(this JsonFormatter f, glTFMaterialEmissiveTextureInfo value)
    {
        f.BeginMap(0); // dummy

        
        {
            f.Key("index"); f.GenSerialize(value.index);
        }

        
        {
            f.Key("texCoord"); f.GenSerialize(value.texCoord);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        f.EndMap();
    }

    /// gltf/meshes
    public static void GenSerialize(this JsonFormatter f, List<glTFMesh> value)
    {
        f.BeginList(value.Count);
        foreach (var x in value)
        {
            f.GenSerialize(x);
        }
        f.EndList();
    }

    /// gltf/meshes[]
    public static void GenSerialize(this JsonFormatter f, glTFMesh value)
    {
        f.BeginMap(0); // dummy

        if(!string.IsNullOrEmpty(value.name))
        {
            f.Key("name"); f.GenSerialize(value.name);
        }

        if(value.primitives!=null && value.primitives.Count>0)
        {
            f.Key("primitives"); f.GenSerialize(value.primitives);
        }

        if(value.weights!=null && value.weights.Length>0)
        {
            f.Key("weights"); f.GenSerialize(value.weights);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        f.EndMap();
    }

    /// gltf/meshes[]/primitives
    public static void GenSerialize(this JsonFormatter f, List<glTFPrimitives> value)
    {
        f.BeginList(value.Count);
        foreach (var x in value)
        {
            f.GenSerialize(x);
        }
        f.EndList();
    }

    /// gltf/meshes[]/primitives[]
    public static void GenSerialize(this JsonFormatter f, glTFPrimitives value)
    {
        f.BeginMap(0); // dummy

        
        {
            f.Key("mode"); f.GenSerialize(value.mode);
        }

        
        {
            f.Key("indices"); f.GenSerialize(value.indices);
        }

        if(value.attributes!=null)
        {
            f.Key("attributes"); f.GenSerialize(value.attributes);
        }

        
        {
            f.Key("material"); f.GenSerialize(value.material);
        }

        if(value.targets!=null && value.targets.Count>0)
        {
            f.Key("targets"); f.GenSerialize(value.targets);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        f.EndMap();
    }

    /// gltf/meshes[]/primitives[]/attributes
    public static void GenSerialize(this JsonFormatter f, glTFAttributes value)
    {
        f.BeginMap(0); // dummy

        if(value.POSITION!=-1)
        {
            f.Key("POSITION"); f.GenSerialize(value.POSITION);
        }

        if(value.NORMAL!=-1)
        {
            f.Key("NORMAL"); f.GenSerialize(value.NORMAL);
        }

        if(value.TANGENT!=-1)
        {
            f.Key("TANGENT"); f.GenSerialize(value.TANGENT);
        }

        if(value.TEXCOORD_0!=-1)
        {
            f.Key("TEXCOORD_0"); f.GenSerialize(value.TEXCOORD_0);
        }

        if(value.TEXCOORD_1!=-1)
        {
            f.Key("TEXCOORD_1"); f.GenSerialize(value.TEXCOORD_1);
        }

        if(value.COLOR_0!=-1)
        {
            f.Key("COLOR_0"); f.GenSerialize(value.COLOR_0);
        }

        if(value.JOINTS_0!=-1)
        {
            f.Key("JOINTS_0"); f.GenSerialize(value.JOINTS_0);
        }

        if(value.WEIGHTS_0!=-1)
        {
            f.Key("WEIGHTS_0"); f.GenSerialize(value.WEIGHTS_0);
        }

        f.EndMap();
    }

    /// gltf/meshes[]/primitives[]/targets
    public static void GenSerialize(this JsonFormatter f, List<gltfMorphTarget> value)
    {
        f.BeginList(value.Count);
        foreach (var x in value)
        {
            f.GenSerialize(x);
        }
        f.EndList();
    }

    /// gltf/meshes[]/primitives[]/targets[]
    public static void GenSerialize(this JsonFormatter f, gltfMorphTarget value)
    {
        f.BeginMap(0); // dummy

        if(value.POSITION!=-1)
        {
            f.Key("POSITION"); f.GenSerialize(value.POSITION);
        }

        if(value.NORMAL!=-1)
        {
            f.Key("NORMAL"); f.GenSerialize(value.NORMAL);
        }

        if(value.TANGENT!=-1)
        {
            f.Key("TANGENT"); f.GenSerialize(value.TANGENT);
        }

        f.EndMap();
    }

    /// gltf/nodes
    public static void GenSerialize(this JsonFormatter f, List<glTFNode> value)
    {
        f.BeginList(value.Count);
        foreach (var x in value)
        {
            f.GenSerialize(x);
        }
        f.EndList();
    }

    /// gltf/nodes[]
    public static void GenSerialize(this JsonFormatter f, glTFNode value)
    {
        f.BeginMap(0); // dummy

        if(!string.IsNullOrEmpty(value.name))
        {
            f.Key("name"); f.GenSerialize(value.name);
        }

        if(value.children != null && value.children.Length>0)
        {
            f.Key("children"); f.GenSerialize(value.children);
        }

        if(value.matrix!=null)
        {
            f.Key("matrix"); f.GenSerialize(value.matrix);
        }

        if(value.translation!=null)
        {
            f.Key("translation"); f.GenSerialize(value.translation);
        }

        if(value.rotation!=null)
        {
            f.Key("rotation"); f.GenSerialize(value.rotation);
        }

        if(value.scale!=null)
        {
            f.Key("scale"); f.GenSerialize(value.scale);
        }

        if(value.mesh!=-1)
        {
            f.Key("mesh"); f.GenSerialize(value.mesh);
        }

        if(value.skin!=-1)
        {
            f.Key("skin"); f.GenSerialize(value.skin);
        }

        if(value.weights!=null)
        {
            f.Key("weights"); f.GenSerialize(value.weights);
        }

        if(value.camera!=-1)
        {
            f.Key("camera"); f.GenSerialize(value.camera);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        f.EndMap();
    }

    /// gltf/nodes[]/children
    public static void GenSerialize(this JsonFormatter f, Int32[] value)
    {
        f.BeginList(value.Length);
        foreach (var x in value)
        {
            f.GenSerialize(x);
        }
        f.EndList();
    }
                    
    /// gltf/skins
    public static void GenSerialize(this JsonFormatter f, List<glTFSkin> value)
    {
        f.BeginList(value.Count);
        foreach (var x in value)
        {
            f.GenSerialize(x);
        }
        f.EndList();
    }

    /// gltf/skins[]
    public static void GenSerialize(this JsonFormatter f, glTFSkin value)
    {
        f.BeginMap(0); // dummy

        
        {
            f.Key("inverseBindMatrices"); f.GenSerialize(value.inverseBindMatrices);
        }

        if(value.joints!=null && value.joints.Length>0)
        {
            f.Key("joints"); f.GenSerialize(value.joints);
        }

        if(value.skeleton!=-1)
        {
            f.Key("skeleton"); f.GenSerialize(value.skeleton);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        if(!string.IsNullOrEmpty(value.name))
        {
            f.Key("name"); f.GenSerialize(value.name);
        }

        f.EndMap();
    }

    /// gltf/scenes
    public static void GenSerialize(this JsonFormatter f, List<gltfScene> value)
    {
        f.BeginList(value.Count);
        foreach (var x in value)
        {
            f.GenSerialize(x);
        }
        f.EndList();
    }

    /// gltf/scenes[]
    public static void GenSerialize(this JsonFormatter f, gltfScene value)
    {
        f.BeginMap(0); // dummy

        if(value.nodes!=null && value.nodes.Length>0)
        {
            f.Key("nodes"); f.GenSerialize(value.nodes);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        if(!string.IsNullOrEmpty(value.name))
        {
            f.Key("name"); f.GenSerialize(value.name);
        }

        f.EndMap();
    }

    /// gltf/animations
    public static void GenSerialize(this JsonFormatter f, List<glTFAnimation> value)
    {
        f.BeginList(value.Count);
        foreach (var x in value)
        {
            f.GenSerialize(x);
        }
        f.EndList();
    }

    /// gltf/animations[]
    public static void GenSerialize(this JsonFormatter f, glTFAnimation value)
    {
        f.BeginMap(0); // dummy

        if(!string.IsNullOrEmpty(value.name))
        {
            f.Key("name"); f.GenSerialize(value.name);
        }

        if(value.channels!=null && value.channels.Count>0)
        {
            f.Key("channels"); f.GenSerialize(value.channels);
        }

        if(value.samplers!=null && value.samplers.Count>0)
        {
            f.Key("samplers"); f.GenSerialize(value.samplers);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        f.EndMap();
    }

    /// gltf/animations[]/channels
    public static void GenSerialize(this JsonFormatter f, List<glTFAnimationChannel> value)
    {
        f.BeginList(value.Count);
        foreach (var x in value)
        {
            f.GenSerialize(x);
        }
        f.EndList();
    }

    /// gltf/animations[]/channels[]
    public static void GenSerialize(this JsonFormatter f, glTFAnimationChannel value)
    {
        f.BeginMap(0); // dummy

        
        {
            f.Key("sampler"); f.GenSerialize(value.sampler);
        }

        if(value!=null)
        {
            f.Key("target"); f.GenSerialize(value.target);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        f.EndMap();
    }

    /// gltf/animations[]/channels[]/target
    public static void GenSerialize(this JsonFormatter f, glTFAnimationTarget value)
    {
        f.BeginMap(0); // dummy

        
        {
            f.Key("node"); f.GenSerialize(value.node);
        }

        if(!string.IsNullOrEmpty(value.path))
        {
            f.Key("path"); f.GenSerialize(value.path);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        f.EndMap();
    }

    /// gltf/animations[]/samplers
    public static void GenSerialize(this JsonFormatter f, List<glTFAnimationSampler> value)
    {
        f.BeginList(value.Count);
        foreach (var x in value)
        {
            f.GenSerialize(x);
        }
        f.EndList();
    }

    /// gltf/animations[]/samplers[]
    public static void GenSerialize(this JsonFormatter f, glTFAnimationSampler value)
    {
        f.BeginMap(0); // dummy

        
        {
            f.Key("input"); f.GenSerialize(value.input);
        }

        if(!string.IsNullOrEmpty(value.interpolation))
        {
            f.Key("interpolation"); f.GenSerialize(value.interpolation);
        }

        
        {
            f.Key("output"); f.GenSerialize(value.output);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        f.EndMap();
    }

    /// gltf/cameras
    public static void GenSerialize(this JsonFormatter f, List<glTFCamera> value)
    {
        f.BeginList(value.Count);
        foreach (var x in value)
        {
            f.GenSerialize(x);
        }
        f.EndList();
    }

    /// gltf/cameras[]
    public static void GenSerialize(this JsonFormatter f, glTFCamera value)
    {
        f.BeginMap(0); // dummy

        if(value.orthographic!=null)
        {
            f.Key("orthographic"); f.GenSerialize(value.orthographic);
        }

        if(value.perspective!=null)
        {
            f.Key("perspective"); f.GenSerialize(value.perspective);
        }

        
        {
            f.Key("type"); f.GenSerialize(value.type);
        }

        if(!string.IsNullOrEmpty(value.name))
        {
            f.Key("name"); f.GenSerialize(value.name);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        f.EndMap();
    }

    /// gltf/cameras[]/orthographic
    public static void GenSerialize(this JsonFormatter f, glTFOrthographic value)
    {
        f.BeginMap(0); // dummy

        
        {
            f.Key("xmag"); f.GenSerialize(value.xmag);
        }

        
        {
            f.Key("ymag"); f.GenSerialize(value.ymag);
        }

        
        {
            f.Key("zfar"); f.GenSerialize(value.zfar);
        }

        
        {
            f.Key("znear"); f.GenSerialize(value.znear);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        f.EndMap();
    }

    /// gltf/cameras[]/perspective
    public static void GenSerialize(this JsonFormatter f, glTFPerspective value)
    {
        f.BeginMap(0); // dummy

        
        {
            f.Key("aspectRatio"); f.GenSerialize(value.aspectRatio);
        }

        
        {
            f.Key("yfov"); f.GenSerialize(value.yfov);
        }

        
        {
            f.Key("zfar"); f.GenSerialize(value.zfar);
        }

        
        {
            f.Key("znear"); f.GenSerialize(value.znear);
        }

        if(value.extensions!=null)
        {
            f.Key("extensions"); f.GenSerialize(value.extensions);
        }

        if(value.extras!=null)
        {
            f.Key("extras"); f.GenSerialize(value.extras);
        }

        f.EndMap();
    }

    public static void GenSerialize(this JsonFormatter f, ProjectionType value)
    {
        f.Value((int)value);
    }

    /// gltf/extensionsUsed
    public static void GenSerialize(this JsonFormatter f, List<String> value)
    {
        f.BeginList(value.Count);
        foreach (var x in value)
        {
            f.GenSerialize(x);
        }
        f.EndList();
    }

    } // class
} // namespace
